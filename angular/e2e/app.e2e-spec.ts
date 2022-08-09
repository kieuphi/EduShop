import { EduShopTemplatePage } from './app.po';

describe('EduShop App', function() {
  let page: EduShopTemplatePage;

  beforeEach(() => {
    page = new EduShopTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
