
import { HotelDto } from './hotel-dto';

import { EntityDto } from '@abp/ng.core';

export class HotelAddressDto extends EntityDto<string> {
  province: string;
  district: string;
  city: string;
  hotelId: string;
  hotel: any;
  id: string;

  constructor(initialValues: Partial<HotelAddressDto> = {}) {
    super(initialValues);
  }
}
