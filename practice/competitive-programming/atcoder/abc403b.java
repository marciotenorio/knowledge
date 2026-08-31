import java.util.Scanner;

public class abc403b {
    public static void main(String[] args) {
        var in = new Scanner(System.in);
        var t = in.nextLine();
        var u = in.nextLine();

        var alphabet = new char[26];
        for (var i = 0; i < alphabet.length; i++)
            alphabet[i] = (char)('a' + i);

        var idx = new int[4];
        for (int i = 0, j=0; i < t.length(); i++)
            if(t.charAt(i) == '?') {
                idx[j] = i;
                ++j;
            }

       for (var i = 0; i < alphabet.length; i++) {
           for (var j = 0; j < alphabet.length; j++) {
               for (var k = 0; k < alphabet.length; k++) {
                   for (var l = 0; l < alphabet.length; l++) {
                       var ct = new StringBuilder(t);
                       ct.setCharAt(idx[0], alphabet[i]);
                       ct.setCharAt(idx[1], alphabet[j]);
                       ct.setCharAt(idx[2], alphabet[k]);
                       ct.setCharAt(idx[3], alphabet[l]);

                       if(ct.toString().contains(u)) {
                           System.out.println("Yes");
                           return;
                       }
                   }
               }
           }
       }

        System.out.println("No");
    }
}