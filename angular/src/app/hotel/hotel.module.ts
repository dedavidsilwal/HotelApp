import { NgModule } from '@angular/core';
import { HotelRoutingModule } from './hotel-routing.module';
import { HotelComponent } from './hotel.component';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [HotelComponent],
  imports: [
    SharedModule,
    HotelRoutingModule
  ]
})
export class HotelModule {
}
