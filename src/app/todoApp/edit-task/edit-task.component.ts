import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-edit-task',
  standalone: true,
  imports: [],
  templateUrl: './edit-task.component.html',
  styleUrl: './edit-task.component.scss'
})
export class EditTaskComponent  { //implements OnInit
   editTaskForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.editTaskForm = this.fb.group({
      name: ['', [Validators.required]],
      group: ['', [Validators.required]],
      status: ['incomplete', [Validators.required]],
      priority: ['medium', [Validators.required]],
      deadline: ['', [Validators.required]],
      description: ['']
    });
  }
  // ngOnInit(): void {
  //   throw new Error('Method not implemented.');
  // }

  onSubmit(): void {
    if (this.editTaskForm.valid) {

    }
  }
}
