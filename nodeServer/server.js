const express = require('express');
const bodyParser = require('body-parser');
const cors = require('cors');

const app = express();

app.use(bodyParser.json());
app.use(cors());
const database = {
  users: [
    {
      id: '123',
      name: 'john',
      email: 'j@g.com',
      password: 'cookies',
      entries: 0,
      joined: new Date()
    },
    {
      id: '124',
      name: 'sally',
      email: 'f@g.com',
      password: 'kookies',
      entries: 0,
      joined: new Date()
    }
  ],
  login: [{
    id: '789',
    has: '',
    email: 'j@v.cm'
  }]
}

app.get('/', (req,res)=> {
  res.send(database.users);
})

app.post('/signin', (req, res) => {
  if (req.body.email === database.users[0].email &&
      req.body.password === database.users[0].password){
        res.json(database.users[0]);
      } else {
        res.status(400).json('error');
      }
})

app.post('/register', (req, res) => {
  const { email, name, password } = req.body;
  database.users.push({
    id: '125',
    name: name,
    email: email,
    password: password,
    entries: 0,
    joined: new Date()
  })
  res.json(database.users[database.users.length-1]);
})

app.get('/profile/:id', (req, res) => {
  const { id } = req.params;
  let found = false;
  database.users.forEach(user => {
    if (user.id === id) {
      found = true;
      return res.json(user);
    }
  })
  if (!found){
    res.status(400).json('not found');
  }
})

app.put('/image', (req, res) => {
  database.users.forEach(user => {
    if (user.id === req.body.id) {
      user.entries++;
      res.json(user);
    }
  });
  res.json('nope');
})

app.listen(3000, () => {
  console.log('app is running');
});