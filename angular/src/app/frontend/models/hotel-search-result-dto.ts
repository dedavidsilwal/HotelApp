

import { ListResultDto } from '@abp/ng.core';

export class HotelSearchResultDto extends ListResultDto<HotelApp.Hotels.HotelSearchResultDto> {
  totalCount: number;
  items: any[];

  constructor(initialValues: Partial<HotelSearchResultDto> = {}) {
    super(initialValues);
  }
}
