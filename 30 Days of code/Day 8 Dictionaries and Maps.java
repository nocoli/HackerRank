//Complete this code or write your own from scratch
import java.util.*;
import java.io.*;

class Solution{
    public static void main(String []argh){
        // Initialise phonebook
        Map<String, String> phoneBook = new HashMap<String, String>();
        
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        for(int i = 0; i < n; i++){
            String name = in.next();
            String phone = in.next();
            
            // Write code here
            phoneBook.put(name, phone);
        }
        while(in.hasNext()){
            String name = in.next();
            
            // Write code here
            if (phoneBook.containsKey(name)) {
				System.out.println(name + "=" + phoneBook.get(name));
			} else {
				System.out.println("Not found");
			}
            
        }
        in.close();
    }
}