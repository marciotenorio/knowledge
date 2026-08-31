package br.com.oopbasics;

public class ExceptionMain {
    public static void main(String[] args) {
        try {
            throwChecked(2);
            throwUnchecked(2);
        } catch (BusinessException e) {
            System.out.println("BusinessException: " + e.getMessage());
        } catch (RuntimeException e) {
            System.out.println("RuntimeException: " + e.getMessage());
        }
    }

    /**
     * You MUST declare throws clause, because is a checked exception.
     * Not declare will turn in a compiler error.
     */
    public static void throwChecked(int i) throws BusinessException {
        if(i % 2 == 0) throw new BusinessException("Não pode ser par.. Checked!");
    }

    /**
     * No need to use throws cluase, because its an unchecked exception
     */
    public static void throwUnchecked(int i) {
        if(i % 2 == 0) throw new SomeException("Não pode ser par.. Unchecked!");
    }
}
