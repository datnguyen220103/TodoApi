import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from './page/header/header.component';
import { FooterComponent } from './page/footer/footer.component';
import { ReactiveFormsModule } from '@angular/forms';
// import { TaskListComponent } from './todoApp/task-list/task-list.component';import { TaskListComponent } from './todoApp/task-list/task-list.component';
import { TaskformComponent } from './page/taskform/taskform.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HeaderComponent, FooterComponent, TaskformComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'WebApi';
}
