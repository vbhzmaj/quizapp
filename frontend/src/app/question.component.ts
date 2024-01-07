import { Component } from "@angular/core";

@Component({
    selector: 'question',
    templateUrl: './question.component.html'
})
export class QuestionComponent {
question: any;
    post(question: any) {
        console.log(question)
    }

}