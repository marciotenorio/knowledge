import { Component } from '@angular/core';

@Component({
  selector: 'app-practice-databinding',
  templateUrl: './practice-databinding.component.html',
  styleUrls: ['./practice-databinding.component.css']
})
export class PracticeDatabindingComponent {

  username = '';

  checkUsername(): boolean {
    console.log('kkk')
    return this.username.length === 0;
  }
}
