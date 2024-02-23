package br.rn.tenorio.tenoriorinha.domain;

import jakarta.persistence.Entity;
import jakarta.persistence.Id;

import java.math.BigInteger;

@Entity
public class Cliente {

    @Id
    private byte id;
    private BigInteger limite;
    private BigInteger saldo;

    public byte getId() {
        return id;
    }

    public void setId(byte id) {
        this.id = id;
    }

    public BigInteger getLimite() {
        return limite;
    }

    public void setLimite(BigInteger limite) {
        this.limite = limite;
    }

    public BigInteger getSaldo() {
        return saldo;
    }

    public void setSaldo(BigInteger saldo) {
        this.saldo = saldo;
    }
}
