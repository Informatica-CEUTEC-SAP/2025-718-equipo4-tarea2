 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44359/',
  redirectUri: baseUrl,
  clientId: 'Autolote_360_App',
  responseType: 'code',
  scope: 'offline_access Autolote_360',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Autolote_360',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44359',
      rootNamespace: 'Autolote_360',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
