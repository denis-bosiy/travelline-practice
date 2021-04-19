import { Component, OnInit } from '@angular/core';

class ToDoItem {
  name: string;
  done: boolean;
  constructor(name: string) {
    this.name = name;
    this.done = false;
  }
}
@Component({
  selector: 'app-todo-app',
  templateUrl: './todo-app.component.html',
  styleUrls: ['./todo-app.component.css']
})
export class TodoAppComponent implements OnInit {

  constructor() { }

  todoText: string = '';
  todos: Array<ToDoItem> = [];

  ngOnInit(): void {
  }

  addTask() : void {
    this.todos.push( new ToDoItem(this.todoText) );
    this.todoText = "";
  }

}
