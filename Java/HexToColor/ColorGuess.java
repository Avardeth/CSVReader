package gdf;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Random;

/**
 *
 * @author Kósa Gyula CHS18H
 */

class ColorGamePanel extends JFrame implements ActionListener {
    
    JPanel pColor = new JPanel();
    JPanel pButtons = new JPanel();
    JPanel pLabel = new JPanel();
    JButton bt1 = new JButton();
    JButton bt2 = new JButton();
    JButton bt3 = new JButton();
    JLabel lbLabel = new JLabel();
    String hex;
    String dummy;
    String dummy2;
    
    public ColorGamePanel() {
        
        setDefaultCloseOperation(javax.swing.JFrame.EXIT_ON_CLOSE);
        setTitle("Hex to Color Game");
        setSize(500,500);
        
        add(pColor, BorderLayout.NORTH);
        add(pButtons, BorderLayout.CENTER);
        add(pLabel, BorderLayout.SOUTH);
        
        pColor.setBackground(randomColor());
        pColor.setPreferredSize(new Dimension(100,180));
        pLabel.setPreferredSize(new Dimension(100,150));
        
        pButtons.add(bt1);
        pButtons.add(bt2);
        pButtons.add(bt3);
        
        pLabel.add(lbLabel = new JLabel("Result"));
        lbLabel.setFont(new Font("Arial", Font.BOLD, 30));
        
        hex();
        random(getHex(), getDummy(), getDummy2());
        
        bt1.addActionListener(this);
        bt2.addActionListener(this);
        bt3.addActionListener(this);
        
    }

    @Override
    public void actionPerformed(ActionEvent e){
       if (e.getActionCommand()==hex)
           lbLabel.setText("You Win");
       else
           lbLabel.setText("You Lose");
    }
   
    //write hex code label to the buttons randomly
    final public void random(String hex, String dummy, String dummy2){
       int a = (int)(Math.random()*2+1);
       switch (a){
               case 1 : bt1.setText(hex);
                        bt2.setText(dummy); bt3.setText(dummy2); break;
               case 2 : bt2.setText(hex);
                        bt1.setText(dummy); bt3.setText(dummy2); break;
               case 3 : bt3.setText(hex);
                        bt2.setText(dummy); bt1.setText(dummy2); break;
       }
       
    }
    
    //get a random color
    final public Color randomColor(){
        Random rand = new Random();
        float r = rand.nextFloat();
        float g = rand.nextFloat();
        float b = rand.nextFloat();
        Color randomColor = new Color(r, g, b);
        return randomColor;
    }
    
    //get random color in hex
    void hex(){
        hex = "#"+Integer.toHexString(randomColor()
                .getRGB()).substring(2).toUpperCase();
        
        do {
            dummy = "#"+Integer.toHexString(randomColor()
                    .getRGB()).substring(2).toUpperCase();
            dummy2 = "#"+Integer.toHexString(randomColor()
                    .getRGB()).substring(2).toUpperCase();
        }while (hex==dummy || hex==dummy || dummy==dummy2);
    }
    
    String getHex(){
        return hex;
    }
    
    String getDummy(){
        return dummy;
    }
    
    String getDummy2(){
        return dummy2;
    }
    
}


public class ColorGuess {
    public static void main(String[] args) {
        new ColorGamePanel().setVisible(true);
        
    }
}
