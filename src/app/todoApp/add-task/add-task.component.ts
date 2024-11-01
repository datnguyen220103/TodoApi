import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-task',
  standalone: true,
  imports: [],
  templateUrl: './add-task.component.html',
  styleUrl: './add-task.component.scss'
})

export class AddTaskComponent {
  taskForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.taskForm = this.fb.group({
      name: ['', [Validators.required]],
      group: ['', [Validators.required]],
      status: [false, [Validators.required]],
      priority: ['medium', [Validators.required]],
      deadline: ['', [Validators.required]],
      description: ['']
    });
  }
   onSubmit(): void {
    if (this.taskForm.valid) {
      console.log('Form Submitted:', this.taskForm.value);
      // Xử lý thêm công việc tại đây
    }
  }
}