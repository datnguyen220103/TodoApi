import { Component } from '@angular/core';
import { TaskListComponent } from '../../todoApp/task-list/task-list.component';
import { AddTaskComponent } from '../../todoApp/add-task/add-task.component';
import { EditTaskComponent } from '../../todoApp/edit-task/edit-task.component';
import { TaskDetailComponent } from '../../todoApp/task-detail/task-detail.component';
@Component({
  selector: 'app-taskform',
  standalone: true,
  imports: [TaskDetailComponent],
  templateUrl: './taskform.component.html',
  styleUrl: './taskform.component.scss'
})
export class TaskformComponent {

}
