package br.com.collections;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.concurrent.ThreadLocalRandom;

public class CS2Match implements Comparable<CS2Match> {
    private Long id;
    private LocalDateTime date;
    private String map;
    private Integer totalKills;

    public CS2Match(LocalDateTime date, String map, int totalKills) {
        this.id = ThreadLocalRandom.current().nextLong(0L, 1_000_000L);
        this.date = date;
        this.map = map;
        this.totalKills = totalKills;

    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public LocalDateTime getDate() {
        return date;
    }

    public void setDate(LocalDateTime date) {
        this.date = date;
    }

    public String getMap() {
        return map;
    }

    public void setMap(String map) {
        this.map = map;
    }

    public Integer getTotalKills() {
        return totalKills;
    }

    public void setTotalKills(Integer totalKills) {
        this.totalKills = totalKills;
    }

    @Override
    public int compareTo(CS2Match o) {
        return id.compareTo(o.id);
    }

    @Override
    public String toString() {
        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("dd-MM-yyyy HH:mm:ss");
        return "CS2Match{" +
                "id=" + id +
                ", date=" + dtf.format(date) +
                ", map='" + map + '\'' +
                ", totalKills=" + totalKills +
                '}';
    }
}
