import { NgModule } from '@angular/core';
import { HotelRoutingModule } from './hotel-routing.module';
import { HotelComponent } from './hotel.component';
import { SharedModule } from '../shared/shared.module';
import { RoomsComponent } from './rooms/rooms.component';
import { RoomComponent } from './room/room.component';

@NgModule({
  declarations: [HotelComponent, RoomsComponent, RoomComponent],
  imports: [
    SharedModule,
    HotelRoutingModule
  ]
})
export class HotelModule {
}
