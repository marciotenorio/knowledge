package com.java.A_01_10_acessando_banco_jdbc;

import org.junit.jupiter.api.*;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.Date;

import static org.junit.jupiter.api.Assertions.*;

@TestMethodOrder(MethodOrderer.OrderAnnotation.class)
@TestInstance(TestInstance.Lifecycle.PER_CLASS)
class EventoDAOTest {

    private static Connection connection;
    private static final String CONNECNTION_PATH = "jdbc:postgresql://localhost:5432/jpa-db";
    private static EventoDAO eventoDAO;
    private static Evento evento;

    @BeforeAll
    static void setUp() throws SQLException {
        connection = DriverManager.getConnection(CONNECNTION_PATH, "postgres", "postgres");
        eventoDAO = new EventoDAO(connection);
    }

    @AfterAll
    static void tearDown() throws SQLException {
        eventoDAO.deleteAll();
        connection.close();
    }

    @Test
    @Order(1)
    void salvar() {
        var evento = new Evento(null, "JavaDay Natal", new Date());
        var id = eventoDAO.salvar(evento);

        evento.setId(id);
        EventoDAOTest.evento = evento;

        assertNotNull(evento.getId());
    }

    @Test
    @Order(2)
    void atualizar() {
        var evento = eventoDAO.buscar(EventoDAOTest.evento.getId());
        evento.setNome("JavaDays Natal");
        eventoDAO.atualizar(evento);
        assertEquals("JavaDays Natal", evento.getNome());
    }

    @Test
    @Order(3)
    void listar() {
        var eventos = eventoDAO.listar();
        assertNotNull(eventos);
    }

    @Test
    @Order(4)
    void delete() {
        eventoDAO.delete(EventoDAOTest.evento.getId());
        Evento evento = eventoDAO.buscar(1);
        assertNull(evento);
    }
}