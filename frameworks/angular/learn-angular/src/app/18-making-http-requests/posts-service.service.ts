import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Post } from './post.model';
import { map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PostsServiceService {
  private readonly basePath = 'http://localhost:3000';

  constructor(private readonly http: HttpClient) { }

  createAndStore(title: string, content: string): void {
    const postData = { title, content };
    this.http
      .post<Post>(
        this.basePath + '/posts',
        postData
      )
      .subscribe(responseData => {
        console.log(responseData);
      });
  }

  fetchPosts() {
    return this.http.get<Post[]>(this.basePath + '/posts')
      .pipe(
        map(res => {
          return res; //only to remember that can use pipe transformations
        })
      );
  }
}
