package com.java.A_01_10_acessando_banco_jdbc;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class EventoDAO {

    private final Connection connection;

    public EventoDAO(Connection connection) {
        this.connection = connection;
    }

    public Integer salvar(Evento evento){
        String sql = "insert into evento (nome, data) values (?, ?)";

        try(PreparedStatement preparedStatement = connection.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS)) {
            preparedStatement.setString(1, evento.getNome());
            preparedStatement.setDate(2, new Date(evento.getData().getTime()));

            preparedStatement.executeUpdate();

            try(ResultSet resultSet = preparedStatement.getGeneratedKeys()){
             resultSet.next();
             return resultSet.getInt(1);
            }

        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public void atualizar(Evento evento) {
        String sql = "update evento set nome = ?, data = ? where id = ?";

        try(PreparedStatement preparedStatement = connection.prepareStatement(sql)) {
            preparedStatement.setString(1, evento.getNome());
            preparedStatement.setDate(2, new Date(evento.getData().getTime()));
            preparedStatement.setInt(3, evento.getId());

            preparedStatement.executeUpdate();

        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public Evento buscar(Integer id) {
        String sql = "select * from evento where id = ?";

        try(PreparedStatement preparedStatement = connection.prepareStatement(sql)) {
            preparedStatement.setInt(1, id);

            try(ResultSet resultSet = preparedStatement.executeQuery()) {
                if(!resultSet.next()) return null;
                return new Evento(id, resultSet.getString("nome"), resultSet.getDate("data"));
            }

        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public List<Evento> listar() {
        String sql = "select * from evento";

        try (PreparedStatement preparedStatement = connection.prepareStatement(sql)) {
            try(ResultSet resultSet = preparedStatement.executeQuery()) {
                var eventos = new ArrayList<Evento>();

                while (resultSet.next()) {
                    eventos.add(
                        new Evento(
                            resultSet.getInt("id"),
                            resultSet.getString("nome"),
                            resultSet.getDate("data")
                        )
                    );
                }
                return eventos;
            }
        }
        catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public void delete(Integer id) {
        String sql = "delete from evento where id = ?";

        try(PreparedStatement preparedStatement = connection.prepareStatement(sql)) {
            preparedStatement.setInt(1, id);
            preparedStatement.executeUpdate();
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public void deleteAll() {
        String sql = "delete from evento;";

        try(PreparedStatement preparedStatement = connection.prepareStatement(sql)) {
            preparedStatement.executeUpdate();
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
}
