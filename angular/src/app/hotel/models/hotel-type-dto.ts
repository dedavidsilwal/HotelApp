

import { EntityDto } from '@abp/ng.core';

export class HotelTypeDto extends EntityDto<string> {
  name: string;
  description: string;
  hotel: any;
  id: string;

  constructor(initialValues: Partial<HotelTypeDto> = {}) {
    super(initialValues);
  }
}
