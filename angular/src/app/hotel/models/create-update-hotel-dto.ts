export class CreateUpdateHotelDto  {
  name: string;
  shortDescription: string;
  fullDescription: string;
  isEnabled: boolean;
  showOnHomePage: boolean;
  allowCustomerReviews: boolean;
  defaultPicture: string;
  address: any;
  location: any;
  hotelType: any;

  constructor(initialValues: Partial<CreateUpdateHotelDto> = {}) {
    if (initialValues) {
      for (const key in initialValues) {
        if (initialValues.hasOwnProperty(key)) {
          this[key] = initialValues[key];
        }
      }
    }
  }
}
