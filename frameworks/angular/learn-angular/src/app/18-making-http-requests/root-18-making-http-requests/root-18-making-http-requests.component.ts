import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { map } from 'rxjs';
import { Post } from '../post.model';
import { PostsServiceService } from '../posts-service.service';

@Component({
  selector: 'app-root-18-making-http-requests',
  templateUrl: './root-18-making-http-requests.component.html',
  styleUrl: './root-18-making-http-requests.component.css'
})
export class Root18MakingHttpRequestsComponent {
  loadedPosts = [];
  isFetching = false;

  constructor(private readonly postsService: PostsServiceService) {}

  ngOnInit() {
    this.isFetching = true;
    this.postsService.fetchPosts() 
      .subscribe(res => {
        this.isFetching = false;
        this.loadedPosts = res;
      });
  }

  onCreatePost(postData: { title: string; content: string }) {
    // Send Http request
    this.postsService.createAndStore(postData.title, postData.content);
  }

  onFetchPosts() {
    // Send Http request
    this.isFetching = true;
    this.postsService.fetchPosts() 
      .subscribe(res => {
        this.isFetching = false;
        this.loadedPosts = res;
      });
  }

  onClearPosts() {
    // Send Http request
  }
}
