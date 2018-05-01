package knightstour;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.Toolkit;
import java.util.concurrent.TimeUnit;
import javax.swing.BorderFactory;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

/**
 *
 * @author Kósa Gyula
 */
public class KnightsTourBoard extends JFrame{
    private Dimension screen = Toolkit.getDefaultToolkit().getScreenSize();
    public static JPanel[][] pnCell;

    public KnightsTourBoard(){
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setTitle("Knight's Tour");
        setBounds(screen.width/2-350, screen.height/2-350, 700, 700);
        setResizable(false);
        setLayout(new BorderLayout());
        
        int row = 8;
        int column = 8;
        
        //cells with border and white background
        JPanel pnBoard=new JPanel(new GridLayout(8, 1));
        pnBoard.setBorder(BorderFactory.createLineBorder(Color.black, 2));
        pnCell = new JPanel[row][column];
        for(int i=0; i<row; i++){
          for(int j=0; j<column; j++) {
            
            pnCell[i][j] = new JPanel();
            pnCell[i][j].setBorder(BorderFactory.createLineBorder(Color.black));
            pnCell[i][j].setBackground(Color.white);
            pnBoard.add(pnCell[i][j]);
          }
        }
        add(pnBoard, BorderLayout.CENTER);
        
        
        //margin
        JPanel pnLeft=new JPanel(new GridLayout(8, 1));
        pnLeft.add(new JLabel("<html><br><br></html>"));
        add(pnLeft, BorderLayout.WEST);
    
        JPanel pnRight=new JPanel(new GridLayout(8, 1));
        pnRight.add(new JLabel("<html><br><br></html>"));
        add(pnRight, BorderLayout.EAST);
        
        JPanel pnTop=new JPanel(new GridLayout(1, 10));
        pnTop.add(new JLabel("<html><br><br></html>"));
        add(pnTop, BorderLayout.NORTH);
        
        JPanel pnBottom=new JPanel(new GridLayout(1, 10));
        pnBottom.add(new JLabel("<html><br><br></html>"));
        add(pnBottom, BorderLayout.SOUTH);
        
    }
    
    public static void main(String[] args) throws InterruptedException {
        new KnightsTourBoard().setVisible(true);
        
        //first 2 move
        KnightsTour.randomStartPoint(7, 0);
        KnightsTour.changeCellBG(KnightsTour.getRandomStartPointRow(),KnightsTour.getRandomStartPointCol());
        KnightsTour.randomMove(KnightsTour.getRandomStartPointRow(), KnightsTour.getRandomStartPointCol());
        TimeUnit.SECONDS.sleep(2);
        KnightsTour.changeCellBG(KnightsTour.getRandomMoveRow(),KnightsTour.getRandomMoveCol());
        //
        
        int a = 0;
        
        do{
            TimeUnit.SECONDS.sleep(2);
            KnightsTour.randomMove(KnightsTour.getRandomMoveRow(), KnightsTour.getRandomMoveCol());
            KnightsTour.changeCellBG(KnightsTour.getRandomMoveRow(),KnightsTour.getRandomMoveCol());
            a++;
            
        }while (a != 30);
        
    }
    
}
