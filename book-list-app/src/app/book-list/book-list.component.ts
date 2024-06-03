import { Component, OnInit } from '@angular/core';
import { Book } from '../models/book';
import { CommonModule } from '@angular/common';
import { BookService } from '../services/book.service';

@Component({
  selector: 'app-book-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './book-list.component.html',
  styleUrl: './book-list.component.css'
})
export class BookListComponent implements OnInit {

  /**
   *
   */
  constructor(private bookService: BookService) {
    
    
  }
  books : Book[] = [];

  ngOnInit(): void {
      this.getBooks();
  }


 

  getBooks(): void {
    this.bookService.getBooks().subscribe(booksApi => this.books = booksApi);
  }
}
