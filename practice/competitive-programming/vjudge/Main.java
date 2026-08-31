import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.time.Duration;
import java.time.Instant;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
import java.util.stream.IntStream;

public class Main {
    public static void main(String[] args) throws IOException {
        if(args[0].equals("-b")) {
            int size = Integer.parseInt(args[1]);
            for (int i = 0; i < size; i++) {
                buffered();
            }
        }
        if(args[0].equals("-s")) {
            int size = Integer.parseInt(args[1]);
            for (int i = 0; i < size; i++) {
                scanner();
            }
        }
    }

    public static void scanner() throws IOException {
        System.out.println("--- SCANNER ---");
        var start = Instant.now();

        var lines = new ArrayList<Integer>();
        var scan = new Scanner(System.in);
        for (int i = 0; i < 1_000_000; i++) {
            lines.add(Integer.parseInt(scan.nextLine()));
        }
        
        var end = Instant.now();
        System.out.println(Duration.between(start, end).toMillis() + " ms");
        System.out.println("Total: " + lines.size());
        lines.clear();
        scan.close();
    }

    public static void buffered() throws IOException {
        System.out.println("--- BUFFERED ---");
        var start = Instant.now();

        var lines = new ArrayList<Integer>();
        try(BufferedReader bf = new BufferedReader(new InputStreamReader(System.in))) {
            for (int i = 0; i < 1_000_000; i++) {
                lines.add(Integer.parseInt(bf.readLine()));
            }
        }
        
        var end = Instant.now();
        System.out.println(Duration.between(start, end).toMillis() + " ms");
        System.out.println("Total: " + lines.size());
        lines.clear();
       
    }
}