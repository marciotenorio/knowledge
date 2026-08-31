package com.learn.springstudy.helloworld;

import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;

import java.util.List;

@Component
public class Setup implements CommandLineRunner {

    private final HelloWorldRepository repository;

    public Setup(HelloWorldRepository repository) {
        this.repository = repository;
    }

    @Override
    public void run(String... args) throws Exception {
        var h1 = new HelloWorld();
        h1.setName("Márcio Tenório");
        var h2 = new HelloWorld();
        h2.setName("Jose Tenório");

        repository.saveAll(List.of(h1, h2));
    }
}
