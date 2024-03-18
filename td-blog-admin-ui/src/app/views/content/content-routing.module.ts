import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import{ PostComponent } from './posts/post.component';
import{AuthGuard} from 'src/app/shared/auth.guard';
import{PostCategoryComponent} from 'src/app/views/content/post-categories/post-category.component';
import { SeriesComponent } from './series/series.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'posts',
    pathMatch: 'full'
  },
  {
    path: 'posts',
    component: PostComponent,
    data: {
      title: 'Bài viết',
      requiredPolicy: 'Permissions.Posts.View',
    },
    canActivate:[AuthGuard],
  },
  {
    path: 'post-categories',
    component: PostCategoryComponent,
    data: {
      title: 'Bài viết',
      requiredPolicy: 'Permissions.PostCategories.View',
    },
    canActivate:[AuthGuard],
  },
  {
    path: 'series',
    component: SeriesComponent,
    data: {
      requiredPolicy:'Permissions.Series.View',
    },
    canActivate:[AuthGuard],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ContentRoutingModule {
}
