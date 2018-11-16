const express = require('express');
const bodyParser = require('body-parser');
const cors = require('cors');
const knex = require('knex');
const bcrypt = require('bcrypt-nodejs');

const pg = knex({
  client: 'pg',
  connection: {
    host : 'localhost',
    user : 'postgres',
    password : 'root',
    database : 'smart-brain'
  }
});

console.log(postgres.select('*').from('users'))

const app = express();

app.use(bodyParser.json());
app.use(cors());

app.get('/', (req,res)=> {
  res.send(database.users);
})

app.post('/signin', (req, res) => {
  pg.select('email', 'hash').from('login')
    .where('email', '=', req.body.email)
    .then(data => {
      const isValid = data[0].compareSync(req.body.password, data[0].hash);
      if (isValid) {
        return pg.select('*').from('users')
          .where('email', '=', req.body.email)
          .then(user => {
            res.json(user[0])
          })
          .catch(err => res.status(400).json('unable to get user'))
      } else {
        res.status(400).json('wrong')
      }
    })
    .catch(err => res.status(400).json('wrong'))
})

app.post('/register', (req, res) => {
  const { email, name, password } = req.body;
  const hash = bcrypt.hashSync(password);
  pg.transaction(trx => {
    trx.insert({
      hash: hash,
      email: email
    })
    .into('login')
    .returning('email')
    .then(loginEmail => {
      return trx('users')
        .returning('*')
        .insert({
          name: loginEmail[0],
          email: email,
          joined: new Date()
        })
        .then(user => res.json(user[0]))
    })
    .then(trx.commit)
    .then(trx.rollback)
  })
  .catch(err => res.status(400).json('unable to join'))
})

app.get('/profile/:id', (req, res) => {
  const { id } = req.params;
  pg.select('*').from('users').where({id})
    .then(user => {
      if (user.length)
        res.json(user[0])
      else
        res.status(400).json('not found')
    })
    .catch(err => res.status(400).json('error user'))
})

app.put('/image', (req, res) => {
  const { id } = req.body;
  pg('users')
    .where('id', '=', id)
    .increment('entries', 1)
    .returning('entries')
    .then(entries => res.json(entries[0]))
    .catch(err => res.status(400).json('unable to get entries'))
})

app.listen(3000, () => {
  console.log('app is running');
});
