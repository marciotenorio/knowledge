import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { map, Subscription } from 'rxjs';
import { Post } from '../post.model';
import { PostsServiceService } from '../posts-service.service';

@Component({
  selector: 'app-root-18-making-http-requests',
  templateUrl: './root-18-making-http-requests.component.html',
  styleUrl: './root-18-making-http-requests.component.css'
})
export class Root18MakingHttpRequestsComponent 
  implements OnInit, OnDestroy {
  loadedPosts = [];
  isFetching = false;
  error = null;
  errorSub: Subscription;

  constructor(private readonly postsService: PostsServiceService) {}

  ngOnInit() {
    this.isFetching = true;
    this.errorSub = this.postsService.error.subscribe(error => {
      this.error = error
      console.log(error)
    });
    this.postsService.fetchPosts().subscribe({
      next: (res) => {
        setTimeout(() => {
          this.isFetching = false;
          this.loadedPosts = res;
        }, 2000);
      },
      error: (error) => {
        this.error = error.message;
      },
    });
  }

  ngOnDestroy(): void {
    if (this.errorSub) {
      this.errorSub.unsubscribe();
    }
  }

  onCreatePost(postData: { title: string; content: string }) {
    // Send Http request
    this.postsService.createAndStore(postData.title, postData.content);
  }

  onFetchPosts() {
    // Send Http request
    this.isFetching = true;
    this.postsService.fetchPosts().subscribe({
      next: (res) => {
        setTimeout(() => {
          this.isFetching = false;
          this.loadedPosts = res;
        }, 1000);
      },
      error: (error) => {
        this.error = error.message;
      },
    });
  }

  onClearPosts() {
    // Send Http request
    this.postsService.deletePosts();
  }

  onHandleError() {
    this.error = null;
    this.isFetching = false;
  }
}
