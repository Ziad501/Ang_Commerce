import { Category } from '../types/category.type';

export const categories: Category[] = [
  {
    id: 1,
    name: 'Men',
    parentCategoryId: null
  },
  {
    id: 2,
    name: 'Women',
    parentCategoryId: null
  },
  {
    id: 3,
    name: 'Kids',
    parentCategoryId: null
  },
  {
    id: 4,
    name: 'Casual Wear',
    parentCategoryId: 1
  },
  {
    id: 5,
    name: 'Party Wear',
    parentCategoryId: 2
  },
  {
    id: 6,
    name: 'Foot Wear',
    parentCategoryId: 2
  },
  {
    id: 7,
    name: 'Accessories',
    parentCategoryId: 3
  }
];
