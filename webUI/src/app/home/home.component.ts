import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  registerMode = false;
  transportCardMode = false;
  JourneyMode = false;

  constructor() { }

  ngOnInit(): void {
  }

  registerToggle() {
    this.registerMode = !this.registerMode;
  }

  transportCardToggle() {
    this.transportCardMode = !this.transportCardMode;
    this.JourneyMode = false;
  }

  journeyToggle() {
    this.JourneyMode = !this.JourneyMode;
    this.transportCardMode = false;
  }

}
