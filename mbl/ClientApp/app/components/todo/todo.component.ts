import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { NgForm } from '@angular/forms';

@Component({
    selector: 'todo',
    templateUrl: './todo.component.html'
})
export class TodoComponent {
    public todos: ITodo[] = [];
    newTodo = '';

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {
        this.refershList();
    }

    refershList() {
        this.http.get(this.baseUrl + 'api/Todo')
            .subscribe(result => {
                this.todos = result.json() as ITodo[];
            }, error => console.error(error));
    }

    addNewTodo(f: NgForm): void {
        debugger;
        //var formVal = f.value;
        this.http.post(this.baseUrl + 'api/Todo', this.newTodo)
            .subscribe(result => {
                this.newTodo = '';
                this.todos.push(result.json() as ITodo)
            }, error => console.error(error));
    }
}

interface ITodo {
    id: number,
    title: string,
}