

import { EntityDto } from '@abp/ng.core';

export class HotelLocationDto extends EntityDto<string> {
  latitude: number;
  longitude: number;
  hotelId: string;
  hotel: any;
  id: string;

  constructor(initialValues: Partial<HotelLocationDto> = {}) {
    super(initialValues);
  }
}
