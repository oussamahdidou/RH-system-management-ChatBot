import { Component, OnInit } from '@angular/core';
import { ChatbootService } from '../services/chatboot.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
})
export class HomeComponent implements OnInit {
  output = '';
  ngOnInit(): void {}
}
