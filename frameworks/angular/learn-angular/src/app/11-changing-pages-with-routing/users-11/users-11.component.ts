import { Component } from '@angular/core';

@Component({
  selector: 'app-users-11',
  templateUrl: './users-11.component.html',
  styleUrls: ['./users-11.component.css']
})
export class Users11Component {
  users = [
    {
      id: 1,
      name: 'Max'
    },
    {
      id: 2,
      name: 'Anna'
    },
    {
      id: 3,
      name: 'Chris'
    }
  ];
}
