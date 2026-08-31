import { HttpClient, HttpEventType, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Post } from './post.model';
import { catchError, map, pipe, Subject, tap, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PostsServiceService {
  private readonly basePath = 'http://localhost:3000';
  public error = new Subject<string>();

  constructor(private readonly http: HttpClient) {}

  createAndStore(title: string, content: string): void {
    const postData = { title, content };
    this.http
      .post<Post>(this.basePath + '/posts', postData, { observe: 'response' })
      .subscribe({
        next: (responseData) => {
          console.log(responseData);
        },
        error: (error) => {
          this.error.next(error.message);
        },
      });
  }

  fetchPosts() {
    return this.http
      .get<Post[]>(this.basePath + '/posts', {
        headers: new HttpHeaders({ 'Custom-Header-Example': 'Tony' }),
        params: new HttpParams().set('myQueryParam', 'tony'),
      })
      .pipe(
        map((res) => {
          return res; //only to remember that can use pipe transformations
        }),
        catchError((error) => {
          //send to analytics, do whatever you want
          return throwError(() => error);
        })
      );
  }

  deletePosts() {
    this.http.get<Post[]>(this.basePath + '/posts').subscribe({
      next: (res) => {
        res.forEach((p) => {
          this.http
            .delete(this.basePath + '/posts/' + p.id, { observe: 'events', responseType: 'json' })
            .pipe(
              tap((event: any) => {
                console.log(event);
                if (event.type == HttpEventType.Response)
                  console.log('responsed event type');
              })
            )
            .subscribe((_) => console.log('inside delete' + _))
        });
      },
      error: (error) => (this.error = error.message),
    });
  }
}
