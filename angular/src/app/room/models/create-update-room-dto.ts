
import { BedType } from './bed-type';
export class CreateUpdateRoomDto  {
  name: string;
  description: string;
  capacity: number;
  maxNoOfChildren: number;
  defaultPicture: string;
  price: number;
  bedType: any;
  isSmoking?: boolean;
  isBooked: boolean;
  hotelId: string;

  constructor(initialValues: Partial<CreateUpdateRoomDto> = {}) {
    if (initialValues) {
      for (const key in initialValues) {
        if (initialValues.hasOwnProperty(key)) {
          this[key] = initialValues[key];
        }
      }
    }
  }
}
