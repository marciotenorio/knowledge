import { Component, OnInit } from '@angular/core';
import { Servers11Service } from '../servers-11.service';
import { ActivatedRoute, Params, Router } from '@angular/router';

@Component({
  selector: 'app-server-11',
  templateUrl: './server-11.component.html',
  styleUrls: ['./server-11.component.css']
})
export class Server11Component implements OnInit {
  server: {id: number, name: string, status: string};

  constructor(private servers11Service: Servers11Service,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.server = data['server'];
    });
    // this.route.params.subscribe(
    //   (params: Params) => this.server = this.servers11Service.getServer(+params['id'])
    // );
  }

  onEdit() {
    this.router.navigate(['edit'], { relativeTo: this.route, /*preserveFragment: true,*/ queryParamsHandling: 'preserve' });
  }
}
