import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-error-page-11',
  templateUrl: './error-page-11.component.html',
  styleUrl: './error-page-11.component.css'
})
export class ErrorPage11Component implements OnInit {
  errorMessage: string;

  constructor(private route: ActivatedRoute){ }

  ngOnInit() {
    // Can be a subscribe in a data observable property
    this.errorMessage = this.route.snapshot.data['message'];
  }
}
