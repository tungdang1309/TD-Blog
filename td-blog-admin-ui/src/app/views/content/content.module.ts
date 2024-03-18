import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import { IconModule } from '@coreui/icons-angular';
import { ChartjsModule } from '@coreui/angular-chartjs';

import { ContentRoutingModule } from './content-routing.module';
import { PostCategoryComponent } from './post-categories/post-category.component';
import { PostCategoryDetailComponent } from './post-categories/post-category-detail.component';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { BlockUIModule } from 'primeng/blockui';
import { PaginatorModule } from 'primeng/paginator';
import { PanelModule } from 'primeng/panel';
import { BadgeModule } from 'primeng/badge';
import { CheckboxModule } from 'primeng/checkbox';
import { KeyFilterModule } from 'primeng/keyfilter';
import { TdSharedModule } from 'src/app/shared/modules/td-shared.module';
import { InputTextModule } from 'primeng/inputtext';
import { TableModule } from 'primeng/table';
import { ButtonModule } from 'primeng/button';
import { DropdownModule } from 'primeng/dropdown';
import { InputNumberModule } from 'primeng/inputnumber';
import { ImageModule } from 'primeng/image';
import { DynamicDialogModule } from 'primeng/dynamicdialog';
import { InputTextareaModule } from 'primeng/inputtextarea';
import { EditorModule } from 'primeng/editor';
import { AutoCompleteModule } from 'primeng/autocomplete';
import { PostComponent } from './posts/post.component';
import { PostDetailComponent } from './posts/post-detail.component';
import { PostReturnReasonComponent } from './posts/post-return-reason.component';
import { PostSeriesComponent } from './posts/post-series.component';
import { PostActivityLogsComponent } from './posts/post-activity-logs.component';
import { SeriesComponent } from './series/series.component';
import { SeriesDetailComponent } from './series/series-detail.component';
import { SeriesPostsComponent } from './series/series-posts.component';

@NgModule({
  imports: [
    ContentRoutingModule,
    IconModule,
    CommonModule,
    ReactiveFormsModule,
    ChartjsModule,
    ProgressSpinnerModule,
    PanelModule,
    BlockUIModule,
    PaginatorModule,
    BadgeModule,
    CheckboxModule,
    TableModule,
    KeyFilterModule,
    TdSharedModule,
    ButtonModule,
    InputTextModule,
    InputTextareaModule,
    DropdownModule,
    EditorModule,
    InputNumberModule,
    ImageModule,
    AutoCompleteModule,
    DynamicDialogModule
  ],
  declarations: [
    PostComponent,
    PostDetailComponent,
    PostCategoryComponent,
    PostCategoryDetailComponent,
    SeriesComponent,
    SeriesDetailComponent,
    PostReturnReasonComponent,
    PostSeriesComponent,
    SeriesPostsComponent,
    PostActivityLogsComponent
  ]
})
export class ContentModule {
}
