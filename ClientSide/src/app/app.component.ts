import { Component } from '@angular/core';
import { environment } from '../environments/environment';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'] 
})
export class AppComponent {
  title = 'Ang_Commerce';
  apiUrl = environment.apiUrl; 

  constructor() {
    console.log('API URL:', this.apiUrl); // Logs API URL to console
  }
}
