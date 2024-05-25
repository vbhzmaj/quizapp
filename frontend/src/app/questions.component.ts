import { Component, OnInit } from "@angular/core";
import { ApiService } from "./api.service";

@Component({
    selector: 'questions',
    templateUrl: './questions.component.html'
})
export class QuestionsComponent {

    question:any
    questions:any

    constructor(private api: ApiService) {}

   

    ngOnInit() {
        this.api.getQuestions().subscribe((data)=>{
        console.log('Result - ', data);
        this.questions = data;
    })
        }

    post(question:any) {
        this.api.postQuestion(question)
    }

}