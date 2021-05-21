import { Core5TemplatePage } from './app.po';

describe('Core5 App', function() {
  let page: Core5TemplatePage;

  beforeEach(() => {
    page = new Core5TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
