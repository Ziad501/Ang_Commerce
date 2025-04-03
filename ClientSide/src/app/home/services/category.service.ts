import { Injectable } from '@angular/core';
import { Category } from '../types/category.type';
import { categories } from '../sampleData/categories.data';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private http:HttpClient) { }

  getAllCategories(): Observable<Category[]> {
    return  this.http.get<Category[]>('https://localhost:7014/api/Categories'
);
}
}