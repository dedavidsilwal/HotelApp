const ENV = {
  dev: {
    apiUrl: 'http://localhost:44398',
    oAuthConfig: {
      issuer: 'http://localhost:44398',
      clientId: 'HotelApp_App',
      clientSecret: '1q2w3e*',
      scope: 'HotelApp',
    },
    localization: {
      defaultResourceName: 'HotelApp',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44398',
    oAuthConfig: {
      issuer: 'http://localhost:44398',
      clientId: 'HotelApp_App',
      clientSecret: '1q2w3e*',
      scope: 'HotelApp',
    },
    localization: {
      defaultResourceName: 'HotelApp',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
