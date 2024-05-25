import { Component } from "@angular/core";
import { ApiService } from "./api.service";

@Component({
    selector: 'question',
    templateUrl: './question.component.html',
})

export class QuestionComponent {

    question = {
        Qtext: "",
        CorrectAnswer: "",
        WrongAnswer1: "",
        WrongAnswer2: "",
        WrongAnswer3: ""
    }

    constructor(private api: ApiService) {}

    post(question:any) {
        this.api.postQuestion(question)
    }

}