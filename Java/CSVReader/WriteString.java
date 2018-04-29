/**
 * 
 * 
 * 
 */
package csvreader;

/**
 *
 * @author Kósa Gyula
 */
public class WriteString {
    
    static String arrayString;
    static String fileString;
    
    static void WriteString(String s){
        arrayString = "";
        while(!s.isEmpty()) {
            
            if (s.charAt(0)!=','){
                arrayString+=s.charAt(0);
                s = s.substring(1);
            } else
                break;
        }
        
        
        fileString = s;
        
    } 


    
    public String getArrayString(){
        return arrayString;
    }
    
    public String getFileString(){
        return fileString;
    }
    
}
