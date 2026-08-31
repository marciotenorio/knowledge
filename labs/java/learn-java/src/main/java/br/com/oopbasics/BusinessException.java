package br.com.oopbasics;

public class BusinessException extends Exception {
    public BusinessException() {
    }

    public BusinessException(String message) {
        super(message);
    }
}
