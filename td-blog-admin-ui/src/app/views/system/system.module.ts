import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { SystemRoutingModule } from './system-routing.module';
import { UserComponent } from './user/user.component';
import { RoleComponent } from './roles/role.component';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { BlockUIModule } from 'primeng/blockui';
import { PaginatorModule } from 'primeng/paginator';
import { PanelModule } from 'primeng/panel';
import { CheckboxModule } from 'primeng/checkbox';
import { SharedModule } from 'primeng/api';
import { TableModule } from 'primeng/table';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { RolesDetailComponent } from './roles/roles-detail.component';
import { TdSharedModule } from 'src/app/shared/modules/td-shared.module';
import { KeyFilterModule } from 'primeng/keyfilter';
import { PermissionGrantComponent} from './roles/permission-grant.componet';
import { ChangeEmailComponent } from './user/change-email.component';
import { RoleAssignComponent } from './user/role-assign.component';
import { SetPasswordComponent } from './user/set-password.component';
import { UserDetailComponent } from './user/user-detail.component';
import { BadgeModule } from 'primeng/badge';
import { PickListModule } from 'primeng/picklist';
import { ImageModule } from 'primeng/image';

@NgModule({
  imports: [
    SystemRoutingModule,
    CommonModule,
    ReactiveFormsModule,
    TableModule,
    ProgressSpinnerModule,
    BlockUIModule,
    PaginatorModule,
    PanelModule,
    CheckboxModule,
    ButtonModule,
    InputTextModule,
    KeyFilterModule,
    SharedModule,
    TdSharedModule,
    BadgeModule,
    PickListModule,
    ImageModule
  ],
  declarations: [
    UserComponent, 
    RoleComponent, 
    RolesDetailComponent,
    PermissionGrantComponent,
    ChangeEmailComponent,
    RoleAssignComponent,
    SetPasswordComponent,
    UserDetailComponent],
})
export class SystemModule {}