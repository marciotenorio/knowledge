package br.com.updowncasting;

public class Item {
    private String title;
    private float duration;

    public Item(String title, float duration) {
        this.title = title;
        this.duration = duration;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public float getDuration() {
        return duration;
    }

    public void setDuration(float duration) {
        this.duration = duration;
    }

    @Override
    public String toString() {
        return "Item{" +
                "title='" + title + '\'' +
                ", duration=" + duration +
                '}';
    }
}
