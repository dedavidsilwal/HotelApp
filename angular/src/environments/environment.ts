export const environment = {
  production: false,
  application: {
    name: 'HotelApp',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44398',
    clientId: 'HotelApp_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'HotelApp',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44398',
    },
  },
  localization: {
    defaultResourceName: 'HotelApp',
  },
};
