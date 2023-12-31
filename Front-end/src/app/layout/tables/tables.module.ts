import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { PageHeaderModule } from '../../shared/modules/page-header/page-header.module';

import { TablesRoutingModule } from './tables-routing.module';
import { TablesComponent } from './tables.component';

@NgModule({
    imports: [CommonModule, TablesRoutingModule, PageHeaderModule],
    // declarations: [TablesComponent]
})
export class TablesModule {}
