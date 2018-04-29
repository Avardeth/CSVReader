package csvreader;


import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Kósa Gyula
 */
public class CSVParser {

    
    public static void main(String[] args) {
        fileScan();
        String fileString = getFileScan();
        read(fileString);
        
    }
    
    static WriteString ws = new WriteString();
    static String file;
    
    //read a file and write into a string
    static void fileScan(){
        try {
            String temp;
            FileReader fr = new FileReader("test.txt");
            BufferedReader br = new BufferedReader(fr);
            while ((temp = br.readLine())!= null){
                file += "," + temp;
            }
        } catch (IOException ex) {
            Logger.getLogger(CSVParser.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    //write the string into an arraylist
    static void read(String s){
        ArrayList<String> list = new ArrayList<>();
        
        while(!s.isEmpty()) {
            
            WriteString.WriteString(s);
            
            WriteString.arrayString = ws.getArrayString().trim();
            s = ws.getFileString();
            
            if (s.length()>0)
                s = s.substring(1);
            
            list.add(WriteString.arrayString);
            
            if (s.isEmpty())
                break;
            
        }
        for (int k = 0; k < list.size(); k++) {
            System.out.println(list.get(k));
        }
        
    }
    
    static String getFileScan(){
        return file;
    }
    
}
