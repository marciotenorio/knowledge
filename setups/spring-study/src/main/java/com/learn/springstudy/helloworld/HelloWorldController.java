package com.learn.springstudy.helloworld;

import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("hello-world")
public class HelloWorldController {

    private final HelloWorldRepository repository;

    public HelloWorldController(HelloWorldRepository repository) {
        this.repository = repository;
    }

    @GetMapping
    public ResponseEntity<List<HelloWorld>> helloWorld(){
        return ResponseEntity.ok(repository.findAll());
    }
}
