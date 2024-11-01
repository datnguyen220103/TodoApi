import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';// Import CommonModule

interface Task {
  id: number;
  name: string;
  group: string;
  completed: boolean;
  priority: string;
  dueDate: string;
  createdDate: string;
  description: string;
}

@Component({
  selector: 'app-task-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './task-list.component.html',
  styleUrl: './task-list.component.scss'
})
export class TaskListComponent {
  tasks: Task[] = [
    { id: 1, name: 'Làm toán', group: 'Bài tập', completed: false, priority: 'Cao', dueDate: '2024-10-31', createdDate: '2024-10-28', description:'' },
    { id: 2, name: 'Chơi đá bóng', group: 'Thể thao', completed: true, priority: 'Thấp', dueDate: '2024-10-30', createdDate: '2024-10-25', description:'' },
  ];
}

