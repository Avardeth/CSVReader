package knightstour;

import java.awt.Color;
import static knightstour.KnightsTourBoard.pnCell;

/**
 *
 * @author Kósa Gyula
 */
public class KnightsTour {
    
    static int startPointRow;
    static int startPointCol;
    static int heading;
    static int angle;
    static int pointRow;
    static int pointCol;
    KnightsTourBoard KTB = new KnightsTourBoard();
    
    public static void randomStartPoint(int max, int min){
        startPointRow = (int)(Math.random()*max+min);
        startPointCol = (int)(Math.random()*max+min);
        System.out.println(startPointRow);
        System.out.println(startPointCol);
    }
    
    public static void randomMove(int row, int col){
        do{
            heading = (int)(Math.random()*4+1);
            angle = (int)(Math.random()*2+1);
            
            switch (heading) {
                case 1: //south
                    pointRow = row + 2;
                    pointCol = (angle == 1) ? col + 1 : col - 1; //east or west
                    break;
                case 2: //east
                    pointCol = col + 2;
                    pointRow = (angle == 1) ? row + 1 : row - 1; //south or north
                    break;
                case 3: //north
                    pointRow = row - 2;
                    pointCol = (angle == 1) ? col - 1 : col + 1; //west or east
                    break;
                case 4: //west
                    pointCol = col - 2;
                    pointRow = (angle == 1) ? row - 1 : row + 1; //north or south
                    break;
                default:
                    break;
            }
            
            System.out.println("row " + pointRow);
            System.out.println("col " + pointCol);
        }while(!(0<=pointRow && pointRow<=7) || !(0<=pointCol && pointCol<=7) || 
                pnCell[pointRow][pointCol].getName() != null);
        
        
    }
    
    static void changeCellBG(int i, int j){
        pnCell[i][j].setBackground(Color.black);
        pnCell[i][j].setName("black");
    }
    
    static int getRandomStartPointRow(){
        return startPointRow;
    }
    
    static int getRandomStartPointCol(){
        return startPointCol;
    }
    
    static int getRandomMoveRow(){
        return pointRow;
    }
    
    static int getRandomMoveCol(){
        return pointCol;
    }
    /*
    public static void main(String[] args) {
        randomStartPoint(8,1);
        randomMove(getRandomStartPointRow(),getRandomStartPointCol());
    }*/
    
}
