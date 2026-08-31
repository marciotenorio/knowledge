package br.com.oopbasics;

/**
 * In Spring you do a BadRequestException for example, extending from RuntimeException
 * because it's an unchecked and the global handler will catch
 */
public class SomeException extends RuntimeException {
    public SomeException() {
    }

    public SomeException(String message) {
        super(message);
    }
}
