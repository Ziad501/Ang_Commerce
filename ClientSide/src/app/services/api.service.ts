import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

export interface Product {
  id: number;
  name: string;
  price: number;
  categoryId: number;
}

export interface Category {
  id: number;
  name: string;
}

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) {
    console.log('API Base URL:', this.apiUrl); // Debugging
  }

  getProducts(): Observable<Product[]> {
    console.log('Fetching Products:', `${this.apiUrl}products`); // Debugging
    return this.http.get<Product[]>(`${this.apiUrl}products`);
  }

  getCategories(): Observable<Category[]> {
    console.log('Fetching Categories:', `${this.apiUrl}categories`); // Debugging
    return this.http.get<Category[]>(`${this.apiUrl}categories`);
  }
}
